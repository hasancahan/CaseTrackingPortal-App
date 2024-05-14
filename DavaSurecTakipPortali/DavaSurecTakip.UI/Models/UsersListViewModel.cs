using DavaSurecTakip.Entities.DbEntitiesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavaSurecTakip.UI.Models
{
    public class UsersListViewModel
    {
        public List<Users> Users { get; internal set; }
        public Users users  { get; set; }
       
    }
}
