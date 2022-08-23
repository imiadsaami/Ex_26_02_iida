using InputUtilitys;
namespace Ex_26_02_iida
{
    internal class Program
    {
        static void Main()
        {
            var width = InputUtility.InputFloat("幅を入力してください");
            var height = InputUtility.InputFloat("高さを入力してください");
            var depth = InputUtility.InputFloat("奥行を入力してください");
            Box box = new Box(width, height, depth);

            Console.WriteLine("表面積 = "+box.GetSurface());
            Console.WriteLine("体積 = "+box.GetVolume());
        }
    }
    class Box
    {
        float width,height,depth;
        public Box(float width,float height,float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        public float GetSurface()
        {
            return (width*height+width*depth+height*depth)*2;
        }
        public float GetVolume()
        {
            return width*height*depth;
        }
    }
}