using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using AccountManagement.Application.Contracts.Log;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.LogAgg;
using AccountManagement.Domain.RoleAgg;
using System.Collections.Generic;
using System.Linq;
//using System.Web.Security;
namespace AccountManagement.Application;

public class AccountApplication : IAccountApplication
{
    private readonly IFileUploader _fileUploader;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IAccountRepository _accountRepository;
    private readonly IAuthHelper _authHelper;
    private readonly IRoleRepository _roleRepository;
    private readonly ILogRepository _logRepository;
    private CreateLog listlog;


    public AccountApplication(IAccountRepository accountRepository, IPasswordHasher passwordHasher,
        IFileUploader fileUploader, IAuthHelper authHelper, IRoleRepository roleRepository
, ILogRepository logRepository)
    {
        _authHelper = authHelper;
        _roleRepository = roleRepository;
        _fileUploader = fileUploader;
        _passwordHasher = passwordHasher;
        _accountRepository = accountRepository;
        _logRepository = logRepository;
    }

    public OperationResult ChangePassword(ChangePassword command)
    {
        var operation = new OperationResult();
        var account = _accountRepository.Get(command.Id);
        if (account == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        if (command.Password != command.RePassword)
            return operation.Failed(ApplicationMessages.PasswordsNotMatch);

        var password = _passwordHasher.Hash(command.Password);
        account.ChangePassword(password);
        _accountRepository.SaveChange();
        return operation.Succedded();
    }

    public AccountViewModel GetAccountBy(long id)
    {
        var account = _accountRepository.Get(id);
        return new AccountViewModel()
        {
            Fullname = account.Fullname,
            Mobile = account.Mobile
        };
    }

    public AccountViewModel GetAccountBy(string username)
    {
        var account = _accountRepository.GetBy(username);
        return new AccountViewModel()
        {
            Fullname = account.Fullname,
            Mobile = account.Mobile,
            Id = account.Id
        };
    }


    public OperationResult Register(RegisterAccount command)
    {
        var operation = new OperationResult();

        if (_accountRepository.Exists(x => x.Username == command.Username || x.Mobile == command.Mobile))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var password = _passwordHasher.Hash(command.Password);
        var path = $"profilePhotos";
        var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
        var account = new Account(command.Fullname, command.Username, password, command.Mobile, command.RoleId,
            picturePath);
        _accountRepository.Create(account);
        _accountRepository.SaveChange();
        return operation.Succedded();
    }

    public OperationResult Edit(EditAccount command)
    {
        var operation = new OperationResult();
        var account = _accountRepository.Get(command.Id);
        if (account == null)
            return operation.Failed(ApplicationMessages.RecordNotFound);

        if (_accountRepository.Exists(x =>
            (x.Username == command.Username || x.Mobile == command.Mobile) && x.Id != command.Id))
            return operation.Failed(ApplicationMessages.DuplicatedRecord);

        var path = $"profilePhotos";
        var picturePath = _fileUploader.Upload(command.ProfilePhoto, path);
        account.Edit(command.Fullname, command.Username, command.Mobile, command.RoleId, picturePath);
        _accountRepository.SaveChange();
        return operation.Succedded();
    }

    public EditAccount GetDetails(long id)
    {
        return _accountRepository.GetDetails(id);
    }

    public OperationResult Login(Login command)
    {
        var operation = new OperationResult();
        var account = _accountRepository.GetBy(command.Username);
        if (account == null)
            return operation.Failed(ApplicationMessages.WrongUserPass);

        // string password = FormsAuthentication.HashPasswordForStoringInConfigFile(command.Password, "MD5");

        var result = _passwordHasher.Check(account.Password, command.Password);

        if (!result.Verified)
            return operation.Failed(ApplicationMessages.WrongUserPass);

        var permissions = _roleRepository.Get(account.RoleId)
            .Permissions
            .Select(x => x.Code)
            .ToList();


        var log = new Log(account.Id, 20, "333");
        _logRepository.Create(log);
        _logRepository.SaveChange();



        //---create session
        // Session.Add("Karbar", dt.Rows[0]["Code_Karbar"].ToString());

        var authViewModel = new AuthViewModel(account.Id, account.RoleId, account.Fullname
            , account.Username, account.Mobile, account.ProfilePhoto, permissions);




        _authHelper.Signin(authViewModel);
        return operation.Succedded();
    }

    public void Logout()
    {
        _authHelper.SignOut();
    }

    public List<AccountViewModel> GetAccounts()
    {
        return _accountRepository.GetAccounts();
    }

    public List<AccountViewModel> Search(AccountSearchModel searchModel)
    {
        return _accountRepository.Search(searchModel);
    }

    public Account GetBy(string username)
    {
        var operation = new OperationResult();
        return _accountRepository.GetBy(username);

    }


}