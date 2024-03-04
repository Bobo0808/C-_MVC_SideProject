using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public 建構子(constructor)，用於初始化ApplicationDbContext類別的實例。

//public 表示這個建構子為公開的，其他程式碼可以使用它。

//(DbContextOptions<ApplicationDbContext> options)：這是建構子的參數，它接受一個名為 options 的參數，該參數的型別是 DbContextOptions<ApplicationDbContext>。這個參數用於配置資料庫連接的選項。

//: base(options)：這是呼叫基底類別（IdentityDbContext）的建構子。我們將 options 參數傳遞給基底類別的建構子。

//IdentityDbContext：這是一個內建的類別，通常用於處理身份驗證和授權相關的資料庫操作。ApplicationDbContext 繼承自 IdentityDbContext，因此它可以使用 IdentityDbContext 提供的功能。

namespace Hospital.Repositories
{
    public class ApplicationDbContext :IdentityDbContext
    {
      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
