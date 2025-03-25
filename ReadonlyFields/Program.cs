using System;

namespace ReadonlyFields
{
    class Configuration
    {
        private readonly int min;
        private readonly int max;

        public Configuration(int v1, int v2)
        {
            min = v1;
            max = v2;
            // readonly(읽기전용)는 생성자 안에서만 초기화
        }

        public void print()
        {
            Console.WriteLine($"{min}, {max}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration c = new Configuration(1, 10); // 생성자 덕분에 객체 생성 시 매개변수에 값 삽입 가능
            c.print();
        }
    }
}
