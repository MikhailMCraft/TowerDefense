﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TDGame.Internals.UI;
using TDGame.GameContent;

namespace TDGame.Internals.Common.GameUI
{
    public class UIPanel : UIElement
    {
        public Color BackgroundColor;

        private void DrawPanel(Texture2D texture, Color color) {
            SpriteBatch spriteBatch = TowerDefense.spriteBatch;
            Rectangle otherInteraction = InteractionBox.ToRectangle();
            Point other = new(otherInteraction.X + otherInteraction.Width - 12, otherInteraction.Y + otherInteraction.Height - 12);
            int width = other.X - otherInteraction.X - 12;
            int height = other.Y - otherInteraction.Y - 12;
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X, otherInteraction.Y, 12, 12), new Rectangle(0, 0, 12, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(other.X, otherInteraction.Y, 12, 12), new Rectangle(16, 0, 12, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X, other.Y, 12, 12), new Rectangle(0, 12 + 4, 12, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(other.X, other.Y, 12, 12), new Rectangle(12 + 4, 12 + 4, 12, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X + 12, otherInteraction.Y, width, 12), new Rectangle(12, 0, 4, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X + 12, other.Y, width, 12), new Rectangle(12, 12 + 4, 4, 12), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X, otherInteraction.Y + 12, 12, height), new Rectangle(0, 12, 12, 4), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(other.X, otherInteraction.Y + 12, 12, height), new Rectangle(12 + 4, 12, 12, 4), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, new Rectangle(otherInteraction.X + 12, otherInteraction.Y + 12, width, height), new Rectangle(12, 12, 4, 4), color, Rotation, Vector2.Zero, SpriteEffects.None, 0f);
        }

        public override void Draw() {
            base.Draw();

            DrawPanel(TowerDefense.UITextures.UIPanelBackground, BackgroundColor);
            DrawPanel(TowerDefense.UITextures.UIPanelBackgroundCorner, BackgroundColor);
        }
    }
}