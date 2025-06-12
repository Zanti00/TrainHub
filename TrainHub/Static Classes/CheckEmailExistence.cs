using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Static_Classes
{
    public static class CheckEmailExistence
    {

        public static bool IsMemberEmailExists(string email, int? excludeMemberId = null)
        {
            try
            {
                using (var dataContext = new Data.TrainHubContext())
                {
                    var query = dataContext.Member.Where(m => m.Email.ToLower() == email.ToLower());

                    if (excludeMemberId.HasValue)
                    {
                        query = query.Where(m => m.Id != excludeMemberId.Value);
                    }

                    return query.Any();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}");
                return false;
            }
        }

        public static bool IsUserEmailExists(string email, int? excludeUserId = null)
        {
            try
            {
                using (var dataContext = new Data.TrainHubContext())
                {
                    var query = dataContext.User.Where(u => u.Email.ToLower() == email.ToLower());

                    if (excludeUserId.HasValue)
                    {
                        query = query.Where(u => u.Id != excludeUserId.Value);
                    }

                    return query.Any();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking email: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> IsMemberEmailExistsAsync(string email, int? excludeMemberId = null)
        {
            return await Task.Run(() => IsMemberEmailExists(email, excludeMemberId));
        }

        public static async Task<bool> IsUserEmailExistsAsync(string email, int? excludeUserId = null)
        {
            return await Task.Run(() => IsUserEmailExists(email, excludeUserId));
        }
    }
}
