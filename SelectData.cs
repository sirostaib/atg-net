using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I might use these classes to store retrieved data from database for each table temporarily
namespace ATG_WPF
{

   


    class SelectAccount
    {
        public string accUsername;
        public string accFullName;
        public string accEmail;
        public string accPhoneNum;
        public string accUserRole;
    }



    //
    class SelectMaintenanceVehicle
    {
        //public string maintenance_id;
        public string vehicle_code;
        public string Check_type;
        public string vehicle_status;
        public DateTime maintenance_date;
    }



}
