   M S B A M L   `   `   `  ����G  CLightMisBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:LightMisBankLightMisBank  5   	       LightMisBank.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:LightMisBank     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  UserLoginPanel��5
   	   $	��450��6    $	��800��6-   .��5      � -   5         �Name$ userLoginInterface��5       � ColumnDefinitions 5   
   �� 5      $	��23* �6   �� 5      $
��137* �6   .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��2��65   $��Stretch=�6I   .��5      � .+�5      �� $��Welcome to LightMisBank��6   $
��Left=�6:   $��10,0,0,0q�6U   $��Center=�6g   
�������$	��306��6�   $��20(�6�   '  !MaterialDesignThemes.Wpf.PopupBox  5      -   5          Name$ UserLoginPopupBox��5   *      PlacementMode$ BottomAndAlignRightEdges=�6E   $��Right=�6n   $��10q�6�      PopupContent. 5      �� .+�5      �� -   5         ��Name$ SystemSettings��5   !   $��1��69   $��系统设置��6I   $
��Left=�6X   $��Center=�6s   $��45��6�   $��80��6�   6�   5      5      5      5      �� 5   
   .+�5      �� -   5         ��Name$ userNameInput��5      $��1��6-   $��Center=�6=   	 �� TextWrapping$
	 Wrap=�6Z   $	��Top=�6n   $	��166��6�   $��31��6�   $��Normal$�6�   
 �� TextAlignment$

 Left=�6�   $��Normal&�6  $��20(�6  $��Normal"�6&   �� Left$	 478��6:  
 �� Top$	 130��6L   �� TextDecorations 6�   Z� 6L  G� 5      -   5         G�Name$ userPasswordInput��5      $��1��65   $
��Left=�6E   $	��Top=�6`   $	��166��6x   $��31��6�   $	 478��6�   $	 212��6�    � Cursor$ Arrow��6�   �� 5      -   5        $ userLoginButton��5      $��1��6.   $��登录��6>   $
��Left=�6K   $	��Top=�6f   $��36��6~   $��67��6�   $	 456��6�   $	 287��6�   $
 Hand��6�   �� 5      -   5        $ userRegisterButton��5      $��1��61   $��注册��6A   $
��Left=�6N   $��Center=�6i   $��36��6�   $��67��6�   $	 577��6�   $	 287��6�   �� 5      -   5         ��Name$ UsernameNoNullLabel��5      $��1��61   $��用户名不能为空！��6A   $
��Left=�6T   $��25��6o   $	��Top=�6{   $	��103��6�   $y�Visible=�6�   $	 652��6�   $	 133��6�   �� 5       -	   5        $ userLoginLabel_Username��5       $��1��65   $��	用户名��6E   $
��Left=�6S   $	��Top=�6n   $	 428��6�   $	 133��6�   �� 5!      -
   5        $ userLoginLabel_Password��5!      $��1��65   $��密码��6E   $
��Left=�6R   $	��Top=�6m   $	 440��6�   $	 213��6�   �� 5"      -   5        $ userLoginLabel_Title��5"      $.��(LightMisBank 错题数据库管理系统��62   $
��Left=�6S   $	��Top=�6n   $��2��6�   $	��330��6�   $��20(�6�   $	 396��6�   $ 69��6�   &   System.Windows.Controls.Calendar  5#      -   5          Name$ UserLogin_Calendar��5#      $ 52��63   $ 61��6D   $��Center=�6T   $	��348��6q   $	��Top=�6~   $|�False��6�    J� IsHitTestVisible$ False��6�   $��False��6�   $	��266��6�   5$      5%      5'      