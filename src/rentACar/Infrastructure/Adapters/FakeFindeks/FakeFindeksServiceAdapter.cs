using Application.Services.FindeksService;
using Infrastructure.OutServices;

namespace Infrastructure.Adapters.FakeFindeks;

public class FakeFindeksServiceAdapter : IFindeksService
{
    public short GetScore(string identityNumber)
    {
        FakeFindeksService service = new();
        return service.GetFindeksScore(identityNumber);
    }
}
