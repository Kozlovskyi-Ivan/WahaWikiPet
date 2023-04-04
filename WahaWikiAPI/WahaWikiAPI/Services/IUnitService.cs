using WahaWikiAPI.Entities;
using WahaWikiAPI.Models;

namespace WahaWikiAPI.Services
{
    public interface IUnitService
    {
        Task<List<Unit>> GetUnitAll();
        Task<Unit?> GetUnitById(int id);
        Task CreateUnit(CreateUnitModel UnitModel);
        Task<Unit?> UpdateUnit(int unitId, CreateUnitModel unitModel);

    }
}
