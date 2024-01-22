using System;
using QRCodeApp.Api.Data;
using QRCodeApp.Api.Repositories.Abstract;
using QRCodeApp.Api.Repositories.Concrete.Common;
using QRCodeApp.Shared.Models;

namespace QRCodeApp.Api.Repositories.Concrete;

public class CardModelRepository : GenericRepository<CardModel>, ICardModelRepository
{
    public CardModelRepository(MyDbContext context) : base(context)
    {
    }
}

