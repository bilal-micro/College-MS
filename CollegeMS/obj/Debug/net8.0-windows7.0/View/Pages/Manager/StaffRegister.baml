   M S B A M L   `   `   `  ����D  @CollegeMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CollegeMS.View.Pages.ManagerCollegeMS.View.Pages.Manager  5      I)clr-namespace:CollegeMS.View.UserControlsCollegeMS.View.UserControls  5      0    *CollegeMS.View.Pages.Manager.StaffRegister   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CollegeMS.View.Pages.Manager     5      BuserControls)clr-namespace:CollegeMS.View.UserControls     5         managerViewModel  � DataContext#  [  5
       N� Title$ StaffRegister��5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   *   $CollegeMS.View.UserControls.TitleBar  �� 5   
   $��1��6    K� ZIndex$ 0��6   ._�5      �� $%��/Assets/Staff data modified.jpg��6   $
��Fill=�6=   5      �� 5   
   $��1��6   $��Enter Staff Data��6"   $��35(�6:   $
��Bold"�6H   
���   �$	��Top=�6n   $��Center=�6�   �� 5   
   $��1��6   $��
Staff Name��6"     
TEXT_BLOCK#��[ 64   $��230,143,480,262q�6X   �� 5   
   $��1��6   $��Password��6!   #��[ 61   $	��100��6U   $��230,201,470,204q�6a   �� 5   
   $��1��6b     textboxx#��[ 6o   $��334,134,306,251q�6�   ��6   �� *
staff.Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��1��6f   #��[ 6s   $��335,193,305,192q�6�   ��6   �� *staff.Password+$ TwoWay=�$ PropertyChanged=�6�   �� 5#   
   $��1��6   $��	Brithdate��6!   #��[ 62   $��538,143,172,262q�6V   �� 5$   
   $��1��6   $��Email��6!   #��[ 6.   $��538,204,172,201q�6R   (  "System.Windows.Controls.DatePicker  5%   
   $��1��6p   $��614,134,26,251q�6~      SelectedDate 6   �� *staff.BirthDate+$ TwoWay=�$ PropertyChanged=�6~   �� 5&   
   $��1��6b   #��[ 6o   $��616,192,24,193q�6�   ��6   �� *staff.Email+$ TwoWay=�$ PropertyChanged=�6�   �� 5)   
   $��1��63   $
��Save��6@     	triggerrr#��[ 6P   $��664,377,26,10q�6t   ��6   �� *RegisterStaff+6t   �� 5*   
   $��DashBoardManager��66   $��1��6Z   $	��↩��6g   $��20(�6s   
�������#��[ 6�   $��Bottom=�6�   $
��Left=�6�   $��	40,0,0,36q�6�   ��6   �� *navigationComand+6�   5,      5-      