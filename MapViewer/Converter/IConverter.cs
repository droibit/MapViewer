﻿using MapViewer.Geometory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapViewer.Converter
{
    /// <summary>
    /// ポリゴンを画面座標に変化するためのコンバータ
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// ポリゴンの座標を画面座標に変換する
        /// </summary>
        /// <returns>
        /// 座標変換したポリゴン
        /// </returns>
        IList<Polygon> Convert();
    }
}