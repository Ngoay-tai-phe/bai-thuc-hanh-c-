namespace Lab6_Bai1
{
    /* Tạo ứng dụng Csharp để minh họa việc sử dụng delegate với các 
yêu cầu sau. - Khai báo 1 delegate với tên InAction có kiểu trả về là void và nhận 1 
tham số đầu vào kiểu int. - Khai báo 1 phương thức static PrintInt kiểu tra về là void và nhận 1 
tham số đầu vào kiểu int. - Khai báo 1 biến action kiểu InAction và gán phương thức PrintInt 
tới biến này. - Gọi thử action(10). - Khai báo phương thức void Perform(InAction aciton, int[] a). - Áp dụng delegate action cho mọi phần tử của mảng, sử dụng foreach 
để duyệt mảng bên trong Perform. - Tạo một mảng số nguyên, và gọi Perform để thực thi. */
    class Program
    {
        public delegate void InAction(int a);
        static void PrintInt(int a)
        {
            Console.WriteLine(a);
        }
        static void Perform(InAction action, int[] b)
        {
            foreach (int x in b)
            {
                action(x);
            }
        }
        static void Main(string[] args)
        {
            InAction action = PrintInt;
            action(10);
            int[] b = { 1, 2, 3, 4, 5 };
            Perform(action, b);
        }
    }
}
