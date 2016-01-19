using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitLine.DataAccess.account;

namespace TransitLine.BusinessLogic
{
    public class AccountProvider
    {
        private static readonly AccountDataAccess account_dataAccess = new AccountDataAccess();
        //身份验证
        public bool IdentityValidate()
        {
            return true;
        }
        //权限验证
        public bool AuthorizationValidate()
        {
            return true;
        }
        //账户验证
        public bool AccountValidate()
        {
            return true;
        }
        //获取账户
        public bool GetAccount()
        {
            return true;
        }
        //修改账户
        public bool ModifyAccount()
        {
            return true;
        }
    }
}
