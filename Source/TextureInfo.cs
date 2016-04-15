using Microsoft.Xna.Framework.Graphics;

namespace RenderBuddy
{
	/// <summary>
	/// Class that wraps up a texture with it's normal and color maps
	/// </summary>
	public class TextureInfo
	{
		#region Properties

		/// <summary>
		/// The texture to be drawn.
		/// </summary>
		public Texture2D Texture { get; set; }

		/// <summary>
		/// The normal map for the texture to be drawn
		/// </summary>
		public Texture2D NormalMap { get; set; }

		/// <summary>
		/// The color mask to be drawn for this image
		/// </summary>
		public Texture2D ColorMask { get; set; }

		public int Width
		{
			get
			{
				return Texture.Width;
			}
		}

		public int Height
		{
			get
			{
				return Texture.Height;
			}
		}

		public bool HasNormal 
		{
			get
			{
				return null != NormalMap;
			}
		}

		public bool HasColorMask 
		{
			get
			{
				return null != ColorMask;
			}
		}

		#endregion //Properties

		#region Methods

		public TextureInfo()
		{
		}

		public TextureInfo(Texture2D tex, Texture2D normalMap = null, Texture2D colorMask = null)
		{
			Texture = tex;
			NormalMap = normalMap;
			ColorMask = colorMask;
		}

		#endregion Methods
	}
}