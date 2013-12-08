﻿using MapViewer.OpenGL.Graphics;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewer.OpenGL.Vertex
{
    /// <summary>
    /// 位置と頂点カラーを持つ頂点情報
    /// </summary>
    public struct VertexPositionColor
    {
        #region Public class

        /// <summary>
        /// 頂点情報の定義
        /// </summary>
        public sealed class Attriute : IVertexAttribute
        {
            #region Private fields

            /// <summary>
            /// 頂点のサイズ
            /// </summary>
            private static readonly int _sizeInBytes = (2 + 4) * 4;

            #endregion

            #region public properties

            #region IVertexAttribute

            public int SizeInBytes
            {
                get { return _sizeInBytes; }
            }

            #endregion

            #endregion

            public void Bind()
            {
                // 頂点情報を有効にする 
                GL.EnableClientState(ArrayCap.VertexArray);
                GL.EnableClientState(ArrayCap.ColorArray);

                //頂点のバッファ領域を指定
                GL.VertexPointer(2, VertexPointerType.Float, SizeInBytes, 0);
                GL.ColorPointer(4, ColorPointerType.Float, SizeInBytes, 8);
            }

            public void Unbind()
            {
                // 頂点情報を無効にする
                GL.DisableClientState(ArrayCap.VertexArray);
                GL.DisableClientState(ArrayCap.ColorArray);
            }
        }

        #endregion

        #region Public properties

        /// <summary>
        /// 頂点の位置
        /// </summary>
        public Vector2 Position
        {
            get;
            set;
        }

        /// <summary>
        /// 頂点カラー
        /// </summary>
        public Color4 Color
        {
            get;
            set;
        }

        #endregion
    }
}