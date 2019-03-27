using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MidiGameMapper.Config;

namespace MidiGameMapper.Test.Config
{
    [TestClass]
    public class ConfigReaderTests
    {
        [TestMethod]
        public void TestRead()
        {
            string xml =
 @"
<midiMapperConfig version=""0.1"">
	<mapping description=""W Key"" profile=""defaultMap"">
		<input name=""midiKey"" value=""159"" description=""C#4"" />
		<output name=""keyboardKey"" value=""W"" />
	</mapping>
	<mapping description=""Mouse"" profile=""defaultMouse"">
		<input name=""upKey"" value=""160"" description=""C#4"" />
		<input name=""downKey"" value=""161"" description=""C#4"" />
		<input name=""leftKey"" value=""162"" description=""C#4"" />
		<input name=""rightKey"" value=""163"" description=""C#4"" />
	</mapping>
</midiMapperConfig>
";
            Configuration config = ConfigReader.Read(xml);

            Assert.IsNotNull(config);
            Assert.AreEqual(2, config.Mappings.Count);

            Mapping defaultMap = config.Mappings[0];
            Assert.AreEqual("defaultMap", defaultMap.Profile);
            Assert.AreEqual("W Key", defaultMap.Description);
            Assert.AreEqual(1, defaultMap.Inputs.Count);

            Input input = defaultMap.Inputs[0];
            Assert.AreEqual("midiKey", input.Name);
            Assert.AreEqual(159, input.Value);
            Assert.AreEqual("C#4", input.Description);

            Assert.AreEqual(1, defaultMap.Outputs.Count);
            Output output = defaultMap.Outputs[0];
            Assert.AreEqual("keyboardKey", output.Name);
            Assert.AreEqual("W", output.Value);
        }
    }
}
