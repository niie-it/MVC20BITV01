namespace Buoi03.Models
{
    public class Test
    {
        public async Task<string> AA()
        {
            await Task.Delay(2000);
            return "Hello";
        }
        public async Task<int> BB()
        {
            await Task.Delay(5000);
            return 777;
        }
        public async Task CC()
        {
            await Task.Delay(3000);
        }

        public string A()
        {
            Thread.Sleep(2000);
            return "Hello";
        }
        public int B()
        {
            Thread.Sleep(5000);
            return 777;
        }
        public void C()
        {
            Thread.Sleep(3000);
        }
    }
}
