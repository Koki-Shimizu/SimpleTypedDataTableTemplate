using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypedDataTableSample
{
    class SimpleTypedDataTableTemplate<T> : DataTable 
        where T : class, new()
    {
        public SimpleTypedDataTableTemplate()
        {
            foreach (var item in typeof(T).GetProperties())
            {
                this.Columns.Add(item.Name, item.PropertyType);
            }
        }

        public void Fill(T[] rows)
        {
            this.Rows.Clear();
            foreach (var row in rows)
            {
                var target_row = this.NewRow();
                foreach (var item in typeof(T).GetProperties())
                {
                    target_row[item.Name] = item.GetValue(row, null);
                }

                this.Rows.Add(target_row);
            }
        }
    }
}
