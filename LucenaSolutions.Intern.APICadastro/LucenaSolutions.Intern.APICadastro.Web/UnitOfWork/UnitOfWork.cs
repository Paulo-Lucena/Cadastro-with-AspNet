﻿using LucenaSolutions.Intern.APICadastro.Web.Data;
using LucenaSolutions.Intern.APICadastro.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LucenaSolutions.Intern.APICadastro.Web.UnitOfWork;

public class UnitOfWork : ControllerBase, IUnitOfWork
{

    private readonly AppDBContext _appDBContext;

    public UnitOfWork(AppDBContext appDBContext)
    {
        _appDBContext = appDBContext;
    }

    public async Task CommitAsync()
    {
        await _appDBContext.SaveChangesAsync();
    }

    public IActionResult RollBack()
    {
        return BadRequest("Ação desfeita");
    }
}