using System.Reflection;

using JUST;

namespace Smart.Kafka.Mock.Core
{
    public class Test
    {
        public void Transform()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //read input from JSON file
            string input = File.ReadAllText($"{path}/schema.json");

            //read the transformer from a JSON file
            string transformer = File.ReadAllText($"{path}/transformer.json");

            // do the actual transformation [equal to new JsonTransformer<JsonPathSelectable>(...) for backward compatibility]
            string transformedString = JsonTransformer.Transform(transformer, input);

            var test = 0;
        }
    }
}