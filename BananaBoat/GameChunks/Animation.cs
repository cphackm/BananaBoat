using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace BananaBoat.GameChunks
{
	public class Animation
	{
		[XmlElement("name")]
		public string name;
		[XmlElement("textureKey")]
		public string sheetKey;

		[XmlElement("loop")]
		public bool isLooping;

		[XmlElement("frameWidth")]
		public int frameWidth;
		[XmlElement("frameHeight")]
		public int frameHeight;

		[XmlElement("frameCount")]
		public int frameCount;
		[XmlArray("frameSpeeds")]
		public List<int> frameSpeeds;

		[XmlArray("imagePoints")]
		public List<int> imagePoints;

		private int currentFrame;
		private float frameDelay;
		private float delayTarget;
		private bool isPaused;
		private float speedScale;

		public Animation()
		{
			currentFrame = 0;
			frameDelay = 0.0f;
			delayTarget = 0.0f;
			isPaused = false;
			speedScale = 1.0f;
		}

		public void Update()
		{
		}

		public void Render()
		{
		}

		public static List<Animation> LoadAnimationsFromXml(string XmlPath)
		{
			// XML deserializer
			XmlSerializer deserializer = new XmlSerializer(typeof(List<Animation>));

			// Load the specified XML file
			XmlReader xmlReader = XmlReader.Create(XmlPath);

			// Deserialize the XML file into a temporary
			List<Animation> animationList = (List<Animation>)deserializer.Deserialize(xmlReader);

			// Close the TextReader
			xmlReader.Close();

			return animationList;
		}
	}
}
