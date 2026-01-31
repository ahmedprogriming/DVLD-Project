using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsApplicatonType
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public int AppTypeID { get; set; }
        public string AppTypeTitle { get; set; }
        public float AppTypeFees { get; set; }

        public clsApplicatonType()
        {
            this.AppTypeID = -1;
            this.AppTypeTitle = "";
            this.AppTypeFees = -1;
            _mode = Mode.AddNew;

        }
        public clsApplicatonType(int ID, string Title, float Fees)
        {
            this.AppTypeID = ID;
            this.AppTypeTitle = Title;
            this.AppTypeFees = Fees;
            _mode = Mode.Update;
        }

        public static DataTable GatAllAppType()
        {
            return clsApplicatonTypeData.GetAllApplicationType();
        }

        private bool _AddNewAppType()
        {
            this.AppTypeID = clsApplicatonTypeData.AddNewApplicationType(this.AppTypeTitle, this.AppTypeFees);
            return (AppTypeID != -1);
        }

        private bool _UpdateAppType()
        {
            return clsApplicatonTypeData.UpdateApplicationType(this.AppTypeID, this.AppTypeTitle, this.AppTypeFees);
        }

        public static clsApplicatonType FindAppTypeID(int AppTypeID)
        {
            string AppTitle = "";
            float AppTypeFees = -1;
            if (clsApplicatonTypeData.GetAllByAppTypeID(AppTypeID, ref AppTitle, ref AppTypeFees))
            {
                return new clsApplicatonType(AppTypeID, AppTitle, AppTypeFees);
            }
            else
            {
                return null;
            }


        }

        public bool Save()
        {
            switch (_mode)
            {
                case Mode.AddNew:
                    if (_AddNewAppType())
                    {
                        return true;
                        _mode = Mode.Update;
                    }
                    else
                    {
                        return false;
                    }
                  
                case Mode.Update:

                    return _UpdateAppType();
            }
            return false;
        }
    }
}
