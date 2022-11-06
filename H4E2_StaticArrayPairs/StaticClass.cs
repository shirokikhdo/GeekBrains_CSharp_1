namespace H4E2_StaticArrayPairs
{
    public static class StaticClass
    {
        public static void Run()
        {
            var array = new Array(20, -10_000, 10_000);
            Serializer.SerializeData(array);

            var resultArray = Serializer.DeserializeData();
            if(resultArray != null)
            {
                ConsoleUtils.OutputData(resultArray);
            }
        }
    }
}