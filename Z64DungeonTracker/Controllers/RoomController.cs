using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z64DungeonTracker.Models;

namespace Z64DungeonTracker.Controllers
{
    public class RoomController : BaseController<RoomModel>
    {
        public RoomController(string conn_string, string db_name, string collection_name)
            : base(conn_string, db_name, collection_name) { }
    }
}
