using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SDCKClient;
using Dal;
using MODEL;
using System.Diagnostics;
using ServiceStack.Redis;
using System.Threading;
using ServiceStack.Messaging.Rcon;

namespace BLL
{
    /// <summary>
    /// 菜单bll
    /// </summary>
   public class MenusBll
    {
        #region 菜单相关显示
        MenusDal MenusDal = new MenusDal();
        /// <summary>
        /// 菜单显示
        /// </summary>
        /// <returns></returns>
        public MenusResponse MenusShow(MenusRequest menusRequest)
        {
            MenusResponse menusResponse = new MenusResponse();
            var ser = MenusDal.MenusShow(menusRequest.Userid);
            if (ser != null)
            {
                menusResponse.DateList = ser;
                menusResponse.IsSuccess = true;
            }
            else
            {
                menusResponse.Status = -1;
                menusResponse.Msg = "显示失败";
                return menusResponse;
            }
            return menusResponse;

        }
        public List<MenusInfo> redis()
        {
            // 打开Redis数据库服务
            var processes = Process.GetProcessesByName("redis-server");
            if (processes.Length == 0)
            {
                //  转义   \\表示\
                Process.Start("E:\\物联网软件\\redis\\redis64-3.0.501\\redis64-3.0.501\\redis-server");          //此处为Redis的存储路径
            }

            using (IRedisClient redisClient = RedisManager.GetClient())
            {
                //获取 Redis数据库User用户表
                var Menus = redisClient.GetTypedClient<MenusInfo>();

                // GetAll()获取所有记录
                if (Menus.GetAll().Count > 0)
                {
                    List<MenusInfo> Menuss = Menus.GetAll().ToList();
                    return Menuss;
                }
                else
                {
                    MenusInfo menus1 = new MenusInfo()
                    {
                        MenusId = 20002,
                        MenusName = "首页",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus2= new MenusInfo()
                    {
                        MenusId = 20004,
                        MenusName = "系统首页",
                        MenusUrl = "/BUser/Index",
                        FatherUrl = "20002",
                    };
                    MenusInfo menus3= new MenusInfo()
                    {
                        MenusId = 20005,
                        MenusName = "个人信息",
                        MenusUrl = "/BUser/personage",
                        FatherUrl = "20002",

                    };
                    MenusInfo menus4= new MenusInfo()
                    {
                        MenusId = 20006,
                        MenusName = "促销",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus5 = new MenusInfo()
                    {
                        MenusId = 20009,
                        MenusName = "秒杀活动列表",
                        MenusUrl = "/promotion/ActivityShow",
                        FatherUrl = "20006",

                    };
                    MenusInfo menus6 = new MenusInfo()
                    {
                        MenusId = 20010,
                        MenusName = "时间段列表",
                        MenusUrl = "/promotion/TimeShow",
                        FatherUrl = "20006",

                    };
                    MenusInfo menus7 = new MenusInfo()
                    {
                        MenusId = 20011,
                        MenusName = "人气推荐",
                        MenusUrl = "/promotion/RecommendShow",
                        FatherUrl = "20006",

                    };
                    MenusInfo menus8 = new MenusInfo()
                    {
                        MenusId = 20012,
                        MenusName = "库存",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus9 = new MenusInfo()
                    {
                        MenusId = 20013,
                        MenusName = "用户出库",
                        MenusUrl = "/Sto/StoreroomFenye",
                        FatherUrl = "20012",

                    };
                    MenusInfo menus10 = new MenusInfo()
                    {
                        MenusId = 20014,
                        MenusName = "用户入库",
                        MenusUrl = "/Sto/StoreroomRu",
                        FatherUrl = "20012",

                    };
                    MenusInfo menus11 = new MenusInfo()
                    {
                        MenusId = 20015,
                        MenusName = "用户",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus12 = new MenusInfo()
                    {
                        MenusId = 20018,
                        MenusName = "用户列表",
                        MenusUrl = "/For/FrontUserFenye",
                        FatherUrl = "20015",

                    };
                    MenusInfo menus13 = new MenusInfo()
                    {
                        MenusId = 20019,
                        MenusName = "用户详情",
                        MenusUrl = "/For/FrontUserShow1",
                        FatherUrl = "20015",

                    };
                    MenusInfo menus14 = new MenusInfo()
                    {
                        MenusId = 20021,
                        MenusName = "会员类别",
                        MenusUrl = "/Mem/MemberShow",
                        FatherUrl = "20015",

                    };

                    MenusInfo menus15 = new MenusInfo()
                    {
                        MenusId = 20022,
                        MenusName = "商品",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus16 = new MenusInfo()
                    {
                        MenusId = 20023,
                        MenusName = "商品显示列表",
                        MenusUrl = "/GoodsShow/GoodsShow",
                        FatherUrl = "20022",

                    };
                    MenusInfo menus17 = new MenusInfo()
                    {
                        MenusId = 20024,
                        MenusName = "订单",
                        MenusUrl = "",
                        FatherUrl = "0",

                    };
                    MenusInfo menus18 = new MenusInfo()
                    {
                        MenusId = 20026,
                        MenusName = "订单显示",
                        MenusUrl = "/Order/Index",
                        FatherUrl = "20024",

                    };
                    MenusInfo menus19 = new MenusInfo()
                    {
                        MenusId = 20027,
                        MenusName = "确定收货 ",
                        MenusUrl = "/Order/TakeGood",
                        FatherUrl = "20024",

                    };
                    MenusInfo menus20 = new MenusInfo()
                    {
                        MenusId = 20028,
                        MenusName = "退货申请处理",
                        MenusUrl = "/Order/ReturnGoods",
                        FatherUrl = "20024",

                    };
                    MenusInfo menus21 = new MenusInfo()
                    {
                        MenusId = 30002,
                        MenusName = "退货原因设置",
                        MenusUrl = "/Order/returnType",
                        FatherUrl = "20024",

                    };
                    MenusInfo menus22 = new MenusInfo()
                    {
                        MenusId = 40002,
                        MenusName = "添加商品",
                        MenusUrl = "/GoodsShow/GoodsAdd",
                        FatherUrl = "20022",

                    };
                    MenusInfo menus23 = new MenusInfo()
                    {
                        MenusId = 40003,
                        MenusName = "商品审核",
                        MenusUrl = "/GoodsShow/audit",
                        FatherUrl = "20022",

                    };
                    List<MenusInfo> MenusToStore = new List<MenusInfo> { menus1, menus2, menus4, menus3, menus5, menus6, menus7, menus8, menus9, menus10, menus11, menus12, menus13, menus14, menus15, menus16, menus17, menus18, menus19, menus20 , menus21, menus22, menus23 };
                    // 存放所有记录
                    Menus.StoreAll(MenusToStore);
                         
                    Thread.Sleep(3000);
                    return MenusToStore;
             
                }
            }
        }

        /// <summary>
        /// 菜单子级的显示
        /// </summary>
        /// <param name="menusRequest"></param>
        /// <returns></returns>
        public MenusSublevelResponse MenusSublevel(MenusSublevelRequest menusSublevelRequest)
        {
            MenusSublevelResponse menusSublevelResponse = new MenusSublevelResponse();
            var menus = redis();
            var currClassUser = menus.Where(c => c.FatherUrl== menusSublevelRequest.FatherUrl.ToString()).ToList();
            if (currClassUser != null)
            {
                menusSublevelResponse.DateList = currClassUser;
                menusSublevelResponse.IsSuccess = true;
            }
            else
            {
                menusSublevelResponse.Status = -1;
                menusSublevelResponse.Msg = "显示失败";
                return menusSublevelResponse;
            }
            return menusSublevelResponse;
        } 
        #endregion
    }
}
