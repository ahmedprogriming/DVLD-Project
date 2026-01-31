using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataAcess_Layer;
using System.Text;
using Bissens_layer;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using Business_Layer;

namespace Bissens_layer
{
    public class clsUser
    {
        enum Mode { AddNew=0, Update=1 };
        private Mode _mode;

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo;
        public string Password { get; set; }
        public string UserName { get; set; }
        public bool IsActive;

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.Password = "";
            this.UserName = "";
            this.IsActive=true;
            _mode = Mode.AddNew;
        }

        public clsUser(int userID,int personID, string Password,string Username, bool isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.Password = Password;
            this.PersonInfo=clsPerson.Find(personID);
            this.UserName = Username;
            this.IsActive = isActive;
            _mode = Mode.Update;
        }

      static  public DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

      static  public clsUser FindByUserID(int UserID)
        {

            int PersonID = -1;
            string Password = "";
            string UserName = "";
            bool IsActive =false; 
           if(clsUserData.GetUserByUserID(UserID,ref PersonID,ref UserName ,ref Password, ref IsActive))
            {
                return new clsUser(UserID,PersonID,Password,UserName,IsActive);
            }
           else
            {
                return null;
            }

      }

        static public clsUser FindByPersonID(int PersonID)
        {

            int UserID = -1;
            string Password = "";
            string UserName = "";
            bool IsActive = false;
            if (clsUserData.GetUserByPersonID(ref UserID, PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Password, UserName, IsActive);
            }
            else
            {
                return null;
            }

        }

        static public clsUser FindByUserNameAndPassword(string UserName,string Password)
        {

            int PersonID = -1;
          
            int UserID = -1;
            bool IsActive = false;
            if (clsUserData.GetUserByUserNameAndPassword(ref UserID, ref PersonID, UserName, Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, Password, UserName, IsActive);
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

        static public bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }
        static public bool IsUserExsites(int UserID)
        {
            return clsUserData.IsUserExites(UserID);
        }

        static public bool IsUserNameExsites(string UserName)
        {
            return clsUserData.IsUserNameExites(UserName);
        }

        static public bool IsUserExsiteForePersonID(int PersonID)
        {
            return clsUserData.IsUserExitesPersonID(PersonID);
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
