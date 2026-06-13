using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.classes
{
    internal class ProductClass
    {
        static public DataTable Get(string filter, string search, string order )
        {
            ConnectionClass.cmd.CommandText = $@"select * from product, name_product, si, provider, manufacturer, category 
where product.id_name_product = name_product.id_name_product 
and product.id_si = si.id_si and product.id_provider = provider.id_provider and 
manufacturer.id_manufacturer = product.id_manufacturer and category.id_category = product.id_category";
            DataTable dt = new DataTable();
            ConnectionClass.adapter.Fill(dt);
            return dt;
        }

        static string GenerateArt()
        {
            string art = "";
            string nums = "1234567890";
            string chars = "QWERTYUIOPASDFGHJHKLZXCVBNM";
            Random random = new Random();   
            foreach (char i in "C000C0")
            {
                if (i == 'C') {
                    art += chars[random.Next(0, chars.Length - 1)];
                }
                else
                {
                    art += nums[random.Next(0, nums.Length - 1)];

                }
            }
            return art;
        }
        static public void Add(string category, string name, string description, string manufacturer, string provider, string cost, string si, string count, string discount, string photo)
        {
            string art = GenerateArt();
            ConnectionClass.cmd.CommandText = $@"insert into product select ifnull(max(id_product, 0))+1, '{art}', {name}, {si}, {cost}, {provider}, {manufacturer}, {category}, {discount}, '{description}', '{photo}' from product";
            if(ConnectionClass.cmd.ExecuteNonQuery() > 0)
            {
                MessageClass.Info("Данные успешно добавлены");
            }
            else
            {

                MessageClass.Error("Данные не были добавлены");
            }
        }
        static public void Update(string id, string category, string name, string description, string manufacturer, string provider, string cost, string si, string count, string discount, string photo)
        {
            string art = GenerateArt();
            ConnectionClass.cmd.CommandText = $@"update product set
                id_name_product = {name},
                id_si = {si}, 
                cost = {cost}, 
                id_provider = {provider}, 
                id_manufacturer = {manufacturer}, 
                id_category = {category}, 
            discount = {discount}, 
            descriptrion = '{description}', 
            photo = '{photo}' where id_product = {id}";
            if(ConnectionClass.cmd.ExecuteNonQuery() > 0)
            {
                MessageClass.Info("Данные успешно обновлены");
            }
            else
            {

                MessageClass.Error("Данные не были обновлены");
            }
        }
    }
}
