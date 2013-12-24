/*
 * 本程序为透明手写板。
 * PaintControls类
 * 负责控制画图的开始与结束，画笔粗细颜色等相关操作。
 * MainCanvas类
 * 该类为画板界面。负责响应画板相关操作及操控BufferCanvas类
 *BufferCanvas类
 *具体显示所画图形的界面。因为一个界面不好实现透明画板...故需要两层画板
 *MainCanvas负责响应鼠标动作，BufferCanvas负责显示所画图形
 *   *.cs文件负责类的窗口界面。*Function.cs负责类的功能实现。
 */