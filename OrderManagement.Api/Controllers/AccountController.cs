using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Api.Models;
using OrderManagement.Core.Models;
using OrderManagement.Core.ApplicationLogic.Accounts;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ApiController<AccountController>
{
    readonly ILogger<AccountController> _logger;
    readonly AccountLogic _accountLogic;
    readonly OrganisationLogic _organisationLogic;
    readonly IMapper _mapper;
    public AccountController(ILogger<AccountController> logger, IMapper mapper, AccountLogic accountLogic, OrganisationLogic organisationLogic)
    {
        _logger = logger;
        _mapper = mapper;
        _accountLogic = accountLogic;
        _organisationLogic = organisationLogic;
    }

    [HttpGet]
    public async Task<IEnumerable<AccountDTO>> Get()
    {
        var accounts = await _accountLogic.GetList(1);
        var result = _mapper.Map<IEnumerable<Account>, IEnumerable<AccountDTO>>(accounts);
        return result;
    }

    [HttpGet("{id}")]
    public async Task<AccountDTO> Get(Guid id)
    {
        var account = await _accountLogic.Get(id);
        var result = _mapper.Map<Account, AccountDTO>(account);
        return result;
    }

    [HttpPost]
    public async Task Post(AccountDTO account)
    {
        var newAccount = _mapper.Map<AccountDTO, Account>(account);
        // Set the owner organisation
        newAccount.Organisation = await _organisationLogic.Get(new Guid("48e16053-daac-11ed-95c6-4cdc697a295f"));

        await _accountLogic.Create(newAccount);
    }
}
