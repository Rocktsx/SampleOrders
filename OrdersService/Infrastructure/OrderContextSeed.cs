using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrdersService.Domain;

namespace OrdersService.Infrastructure
{
    public class OrderContextSeed
    {
        public async Task SeedAsync(OrderDbContext context)
        {
            await ProductsSeed(context); 

        }
        private async Task ProductsSeed(OrderDbContext context)
        {
            if (!context.Products.Any())
            {
                var list = new List<Product>()
                {
                    new Product("Apple iPhone XS Max","Apple iPhone XS Max (A2104) 256GB 深空灰色 移动联通电信4G手机 双卡双待",9599),
                    new Product("Apple iPhone 11","Apple iPhone 11 (A2223) 128GB 黄色",5999),
                    new Product("荣耀9X","麒麟810 4000mAh续航 4800万超清夜拍 6.59英寸升降全面屏 全网通6GB+64GB 魅海",1033),
                    new Product("Redmi K20Pro","Redmi K20Pro 骁龙855 索尼4800万超广角三摄 AMOLED弹出式全面屏 8GB+256GB 冰川蓝 游戏智能手机",2299),
                    new Product("Apple iPhone 11 Pro Max","Apple iPhone 11 Pro Max (A2220) 256GB 暗夜绿色 移动联通电信4G手机 双卡双待",10899),
                    new Product("坚果Pro3","锤子(smartisan) 坚果Pro3 12GB+256GB 松绿 骁龙855PLUS 4800万四摄 UFS3.0 全网通双卡双待 全面屏游戏手机",3599),
                    new Product("Beats Solo Pro","Beats Solo Pro 无线消噪头戴式耳机",2499),
                    new Product("Beats Powerbeats Pro","Beats Powerbeats Pro 完全无线高性能耳机 真无线蓝牙运动耳机",1848),
                    new Product("Apple iPad Pro 12.9英寸平板电脑","Apple iPad Pro 12.9英寸平板电脑 2018款(64G WLAN版/全面屏/A12X/FaceID MTEL2CH/A)深空灰",7669),
                    new Product("Apple iPad Air 3 2019年新款平板电脑","Apple iPad Air 3 2019年新款平板电脑 10.5英寸（64G WLAN版/A12芯片/MUUJ2CH/A）深空灰色",3769),
                    new Product("vivo Z5x 6GB+128GB","vivo Z5x 6GB+128GB 极光色 极点屏手机 5000mAh大电池 三摄拍照手机 移动联通电信全网通4G手机",1398),
                    new Product("小米9","小米9 骁龙855 索尼4800万超广角微距三摄 支持20W无线闪充 8GB+128GB 全息幻彩蓝 智能拍照游戏手机",2399),
                    new Product("联想(Lenovo)拯救者Y7000P","联想(Lenovo)拯救者Y7000P 2019英特尔酷睿i715.6英寸游戏笔记本电脑(i7-9750H 16G 1T SSD GTX1660Ti 144Hz)",9299),
                    new Product("戴尔灵越14燃","戴尔灵越14燃 14英寸英特尔酷睿i7轻薄窄边框笔记本电脑(i7-8565U 8G 256G MX250 2G独显 背光键盘)冰河银",5499)
                };
                context.Products.AddRange(list);
                await context.SaveChangesAsync();
            }
        }
    }
}
