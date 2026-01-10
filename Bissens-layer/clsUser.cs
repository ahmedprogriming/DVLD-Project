using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAcess_Layer;
using System.Text;
using Bissens_layer;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;

namespace Bissens_layer
{
    public class clsUser
    {
        enum Mode { AddNew=0, Update=1 };
        private Mode _mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public int Password { get; set; }
        public string UserName { get; set; }
        public byte IsActive;

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Password = -1;
            this.UserName = "";
            this.IsActive = 1;
            _mode = Mode.AddNew;
        }

        public clsUser(int userID,int personID,int Password,string Username,byte isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.Password = Password;
            this.UserName = Username;
            this.IsActive = isActive;
            _mode = Mode.Update;
        }

      static  public DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

      static  public clsUser Find(int UserID)
        {

            int PersonID = -1;
           int Password= -1;
            string UserName = "";
             byte IsActive=1; 
           if(clsUserData.GetUserByUserID(UserID,ref PersonID,ref UserName ,ref Password, ref IsActive))
            {
                return new clsUser(UserID,PersonID,Password,UserName,IsActive);
            }
           else
            {
                return null;
            }

      }

        static public clsUser Find(string UserNmae)
        {

            int PersonID = -1;
            int Password = -1;
            int UserID = -1;
            byte IsActive = 1;
            if (clsUserData.GetUserByUserName(ref UserID, ref PersonID, UserNmae, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Password, UserNmae, IsActive);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewUser()
        {
            this.UserID=clsUserData.AddNewUser(this.PersonID,this.UserName,this.Password,this.IsActive);
            return (UserID !=-1);
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID,this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public bool DeleteUser()
        {
            return clsUserData.DeleteUser(this.UserID);
        }
        public bool IsUserExsites(int UserID)
        {
            return clsUserData.IsUserExites(UserID);
        }

        public bool Save()
        {
            switch(_mode)
            {
                case Mode.AddNew:
                    if (_AddNewUser())
                    {
                        _mode = Mode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                  
                case Mode.Update:
                             return _UpdateUser();
           
            }
            return false;
        }

    } 
}
