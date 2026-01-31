using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcess_Layer;

namespace Bissens_layer
{
    public class clsTestType
    {
        enum Mode { AddNew = 0, Update = 1 };
        private Mode _mode;
        public enum enTestType { VisionTest=1,WriteTest=2,StreetTest=3};
        public clsTestType.enTestType ID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        public clsTestType()
        {
            this.ID =clsTestType.enTestType.VisionTest;
            this.TestTypeTitle = "";
            this.TestTypeDescription = "";
            this.TestTypeFees = -1;
            _mode = Mode.AddNew;

        }
        public clsTestType(clsTestType.enTestType ID, string Title,string Description, float Fees)
        {
            this.ID= ID;
            this.TestTypeTitle = Title;
            this.TestTypeDescription = Description;
            this.TestTypeFees = Fees;
            _mode = Mode.Update;
        }

        public static DataTable GatAllTestType()
        {
            return clsTestTypeData.GetAllTestType();
        }

        public static clsTestType Find(enTestType type)
        {
            string TestTypeTitle = "";
            string TestTypeDescription = "";
            float TestTypeFees = 0;

            if(clsTestTypeData.GetAllByTestTypeID((int)type,ref TestTypeTitle,ref TestTypeDescription,ref TestTypeFees))
            {
                return new clsTestType(type,TestTypeTitle,TestTypeDescription,TestTypeFees);
            }else
            {
                return null;
            }
        }

        private bool _AddNewTestType()
        {
            this.ID =(clsTestType.enTestType) clsTestTypeData.AddNewTestType(this.TestTypeTitle,this.TestTypeDescription,this.TestTypeFees);
            return (TestTypeTitle !="");
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)this.ID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public static clsTestType FindTestTypeID(clsTestType.enTestType TestTypeID)
        {
            string TestTitle = "";
            string TestDescription = "";
            float testTypeFees = -1;

            if (clsTestTypeData.GetAllByTestTypeID((int)TestTypeID, ref TestTitle,ref TestDescription,ref testTypeFees))
            {
                return new clsTestType(TestTypeID, TestTitle, TestDescription,testTypeFees);
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
                    if (_AddNewTestType())
                    {
                        return true;
                        _mode = Mode.Update;
                    }
                    else
                    {
                        return false;
                    }

                case Mode.Update:

                    return _UpdateTestType();
            }
            return false;
        }
    }
}
