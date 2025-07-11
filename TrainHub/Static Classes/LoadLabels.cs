using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainHub.Static_Classes
{
    public partial class LoadTotalLabels
    {
        public static int LoadTotalNearlyExpiredMembers()
        {
            DateTime today = DateTime.Today;
            DateTime sevenDaysFromToday = today.AddDays(7);

            try
            {
                using (var dataContext = new Data.TrainHubContext())
                {
                    int nearlyEXpiredMemberTotal = dataContext.Member
                        .Where(m => !m.IsDeleted
                        && m.EndDate >= today
                        && m.EndDate <= sevenDaysFromToday
                        && m.Status == "Active")
                        .Count();
                    return nearlyEXpiredMemberTotal;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occurred: {e.Message}");
                return -1;
            }
        }

        public static int LoadMemberAttendanceToday()
        {
            try
            {
                using (var dataContext = new Data.TrainHubContext())
                {
                    int totalMemberToday = dataContext.MemberAttendances
                        .Where(ma => !ma.IsDeleted
                        && ma.AttendanceDate == DateTime.Today)
                        .Count();
                    return totalMemberToday;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occurred: {e.Message}");
                return -1;
            }
        }

        public static int LoadTrainerAttendanceToday()
        {
            try
            {
                using (var dataContext = new Data.TrainHubContext())
                {
                    int totalTrainerToday = dataContext.TrainerAttendances
                        .Where(ta => !ta.IsDeleted
                        && ta.AttendanceDate == DateTime.Today)
                        .Count();
                    return totalTrainerToday;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"An error has occurred: {e.Message}");
                return -1;
            }
        }
    }
}
