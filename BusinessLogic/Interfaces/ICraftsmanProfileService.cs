using BusinessLogic.DTOs.Craftsman;

namespace BusinessLogic.Services.Interfaces
{
    public interface ICraftsmanProfileService
    {
        Task<CraftsmanProfileDto> GetProfileAsync(int id);
    }
}
