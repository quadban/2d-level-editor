﻿#region File Description
/* LevelContent.cs
 * 
 * 
 */
#endregion

#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;
#endregion

using Tile = PlatformerGame.Tile;

namespace PlatformerGamePipeline
{

    [ContentSerializerRuntimeType("PlatformerGame.Level, PlatformerGame")]
    public class LevelContent
    {
        [ContentSerializer]
        public string Name;

        [ContentSerializer]
        public ExternalReference<Texture2DContent> Background;

        [ContentSerializer]
        public TileContent[] TileTypes;

        [ContentSerializer]
        public TileMapContent[] TileMap;
        
    }

    [ContentSerializerRuntimeType("PlatformerGame.Level, PlatformerGame")]
    public class TileContent
    {
        [ContentSerializer]
        public Vector2 Type;

        [ContentSerializer]
        public ExternalReference<Texture2DContent> Texture;

    }

    [ContentSerializerRuntimeType("PlatformerGame.Level, PlatformerGame")]
    public class TileMapContent
    {
        [ContentSerializer]
        public Vector2 Type;

        [ContentSerializer]
        public Vector2 Position;

    }

}
