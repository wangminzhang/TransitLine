using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitLine.Common.Enum;
using TransitLine.Common.EX;

namespace TransitLine.Common.Authorization
{
    public class OpenValidate
    {
        public static bool AuthorizationValidate(Entity.RequestHander requestHander, Entity.BaseAccount baseAccount)
        {
            throw new CustomException("没有权限", (int)ErrorEnum.没有权限);
        }


        public static void IdentityValidate(Entity.RequestHander requestHander, Entity.BaseAccount baseAccount)
        {

            throw new CustomException("请先登录", (int)ErrorEnum.没有登录);
            OpenValidate.AuthorizationValidate(requestHander, baseAccount);

        }
    }
}
