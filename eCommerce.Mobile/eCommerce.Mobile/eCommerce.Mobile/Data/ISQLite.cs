using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Mobile.Data
{
    public interface ISQLite
    {
        SQLiteAsyncConnection Connect();
    }
}
