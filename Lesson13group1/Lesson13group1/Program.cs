// See https://aka.ms/new-console-template for more information
using IronXL;
using Lesson13group1;
using System.Data;

Console.WriteLine("Hello, World!");
MyClass c = new MyClass();
// reflection 
Type t = c.GetType();
c.GetType().GetProperties().ToList().ForEach(p => Console.WriteLine(p.Name));
var props = typeof(Type).GetProperties();
//t.is
c.MyProperty = 4;
c.GetType().GetProperty("MyProperty")?.SetValue(c, 4);
c.GetType().GetMethod("f")?.Invoke(c,null);

var strs = Enum.GetNames<eDays>();
string s=Enum.GetName<eDays>(eDays.sunday)??"";

    WorkBook workbook = WorkBook.Load("file.xlsx");
    //// Work with a single WorkSheet.
    ////you can pass static sheet name like Sheet1 to get that sheet
    ////WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
    //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
    WorkSheet sheet = workbook.DefaultWorkSheet;
    //Convert the worksheet to System.Data.DataTable
    //Boolean parameter sets the first row as column names of your table.
    DataTable dt= sheet.ToDataTable(true);
foreach (var item in dt.Rows)
{
    Lst.add(new Person() { name = item[0] });
}

Console.WriteLine("ghjgjh");
Action f;// מה מותר להציב לכאן
//מה צריך לעשות כדי שהשורה הזאת תהיה חוקית
int x = 6;

x.func(); // פונקצית הרחבה

//  איך אפשר שהשורות הבאות יהיו חוקיות
Func(1, 2, 3, 4);
Func(1, 2, 3);





