   M S B A M L   `   `   `  ����  LightMisBank    LightMisBank.UserSettings   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  基本设置��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � WindowState$ Normal=�6T   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   .��5      � .+�5      �� -   5         ��Name$ UserSettings_General��5      $!��LightMisBank - 系统设置��66   $��20(�6T   $��
ExtraLight"�6b   $��Normal$�6z   $��Normal&�6�   ���	#DDFFFFFF$��	3,5,550,5q�6�   '  !MaterialDesignThemes.Wpf.PopupBox  5      -   5          Name$ SystemAbout��5   *      PlacementMode$ BottomAndAlignRightEdges=�6?   $��Right=�6h   $��10q�6�   	   PopupContent.	 5      �� .+�5      �� -   5        
 ��Name$
 SystemAboutButton��5   !   $��1��6<   $��关于软件��6L   $
��Left=�6[   $��Center=�6v   $��45��6�   $��80��6�   6�   5      5      5      5      � 5   
   $��Stretch=�6   $��1��6-   ���	#FF7600A5 5      �� 5      $
��137* �6#   �� 5       $
��113* �6#    5"      �� 5#      $��70 �6    �� 5$      .+�5&      �� $��Disabled=�6   $
��Auto=�6D   $��2��6g   $��2��6{   .��5'      �� -   5         ��Name$
 Menu��5'      $��10q�6+   5(      5)      �� 5*   
   -   5        $ StackPanelMain��5*      $��2��6-   $��2��6:    �� Orientation$ Vertical=�6J   .+�5+      � -   5         �Name$ StackPanelSQLOptions��5+      $	��389��61   $y�Visible=�6>   .+�5,      �� -   5        $ SQLOptions_SQLPath��5,      $��数据库文件路径��64   $��27��6F   $��14(�6R   $��10,12,414,350q�6`   �� 5-      -   5         ��Name$ SQLOptions_SQLitePath��5-      $��YourSQLitePath��69   $��26��6O   $��14(�6[   $��141,11,10,352q�6i    � Cursor$ Arrow��6�   5.      50      51      52      