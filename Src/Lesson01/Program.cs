namespace Lesson01
{
    //Trong C# comment được biết bằng "//"
    /*
     Đây là multiple comment bắt đầu bằng "/*" và kết thúc bằng "* /"
    */
    //Chạy bằng menu của VS sẽ đưa application vào chế độ debug 
    //Chạy bằng Ctrl + F5 sẽ đưa application vào chế độ release
    class Program
    {
        static void Main(string[] args)//function
        {
            /* Quy tắc đặt tên biến
             * 1. Tên biến chỉ có thể chứa các kí tự sau: [a-z], [A-Z], [0-9] và kí tự '_'
             * 2. Tên biến không được bắt đầu bằng chữ số
             * 3. Tên biến không được trùng với bất kì từ khóa nào của C# và không được trùng với tên biến đã khai báo trước đó
             */
            int int = 4; //Sai vì tên biến int trùng với từ khóa 'int' của C#
            int 0s = 2; //Tên biến không được bắt đầu bằng chữ số
            int da# = 4; //Tên biến không được chứa kí tự đặc biệt
            int a = 3;// Đặt tên biến đúng 
            int a = 4;// Không thể đặt tên biến là 'a' vì biến 'a' trước đó đã được khai báo


            /* Khai báo và khởi tạo biến
             * Trong C# có thể khai báo và khởi tạo giá trị biến cùng lúc. Điều bắt đầu trong lúc khai báo biến
             * là phải xác định cho biến thuộc kiểu dữ liệu nào ứng với giá trị mà bạn mong muốn khởi tạo
             * Khởi tạo chính là gán một giá trị nào đó cho biến phù hợp với kiểu dữ liệu mà biến đó được khai báo
             */
            int b;//Khai báo biến với kiểu dữ liệu là int
            b = 2;//Khởi tạo giá trị cho biến
            int c = 2;//Khai báo và khởi tạo giá trị biến cùng một lúc.



        }
    }
}
