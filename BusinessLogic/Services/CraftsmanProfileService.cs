using BusinessLogic.DTOs.Craftsman;
using BusinessLogic.Services.Interfaces;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogic.Services
{
    public class CraftsmanProfileService : ICraftsmanProfileService
    {
        private readonly Context _context;

        public CraftsmanProfileService(Context context)
        {
            _context = context;
        }

        public async Task<CraftsmanProfileDto?> GetProfileAsync(int id)
        {
            var craftsman = await _context.Craftsmens
                .Include(c => c.User)
                .Include(c => c.Profession)
                .Include(c => c.WorkedCities)
                    .ThenInclude(wc => wc.City)
                .Include(c => c.Skills)
                    .ThenInclude(cs => cs.Skill)
                .Include(c => c.GalleryImages)
                .Include(c => c.Reviews)
                    .ThenInclude(r => r.Reviewer)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (craftsman == null)
                return null;

            return new CraftsmanProfileDto
            {
                Id = craftsman.Id,

                // User Info
                FullName = craftsman.User?.FullName,
                ProfileImage = craftsman.User?.ProfileImage,
                Phone = craftsman.User?.Phone,

                // Basic Info
                Bio = craftsman.Bio,
                Profession = craftsman.Profession?.Name,
                ExperienceYears = craftsman.ExperienceYears,

                // Pricing
                MinPrice = craftsman.MinPrice,
                MaxPrice = craftsman.MaxPrice,

                // Verification
                IsVerified = craftsman.IsVerified,
                VerificationDate = craftsman.VerificationDate,

                // City
                City = craftsman.WorkedCities?
                        .Select(c => c.City.Name)
                        .FirstOrDefault(),

                // Skills
                Skills = craftsman.Skills?
                        .Select(s => s.Skill.Name)
                        .ToList(),

                // Photos
                Photos = craftsman.GalleryImages?
                        .Select(g => g.MediaUrl)
                        .ToList(),

                // Reviews
                AverageRating = craftsman.Reviews.Any()
                    ? craftsman.Reviews.Average(r => r.Stars)
                    : 0,

                Reviews = craftsman.Reviews
                    .Select(r => new ReviewDto
                    {
                        Username = r.Reviewer?.FullName,
                        Stars = r.Stars,
                        Comment = r.Comment
                    })
                    .ToList()
            };
        }
    }
}
