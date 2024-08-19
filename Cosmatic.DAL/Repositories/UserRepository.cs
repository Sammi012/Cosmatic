using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmatic.DAL.Repositories
{
    /// <summary>
    /// This userRepository  contains methods of user reletive
    /// </summary>
    public class UserRepository
    {
        public async Task<bool> InsertUserAsync(Cosmatic.Models.Users users)
        {
            try
            {
                using (var connection = new SqlConnection(
                       ConfigurationManager.AppSettings.Get("")))
                {
                    string query = "";
                }
                return await Task.FromResult(true);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
