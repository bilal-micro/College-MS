   M S B A M L   `   `   `  ����D  @CollegeMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CollegeMS.View.Pages.ManagerCollegeMS.View.Pages.Manager  5      I)clr-namespace:CollegeMS.View.UserControlsCollegeMS.View.UserControls  5      ,    &CollegeMS.View.Pages.Manager.Dashboard   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:CollegeMS.View.Pages.Manager     5      BuserControls)clr-namespace:CollegeMS.View.UserControls     5         managerViewModel  � DataContext#  [  5
       N� Title$ 	Dashboard��5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   *   $CollegeMS.View.UserControls.TitleBar  �� 5   
   $��1��6    K� ZIndex$ 0��6   ._�5      �� $"��\Assets\manage_dashboard.png��6   $
��Fill=�6:   5      �� 5   
   $��1��6   $��College Management System��6!   
�������$��35(�6U   $
��Bold"�6c   $	��Top=�6u   $��Center=�6�   $��Segoe UI)�6�   5      �� 5   
   $��	AllStaffs��66   $��1��6S   $��	All Staff��6`   $��227,266,473,121q�6t     ButtonTransparent#��[ 6�   ��6   �� *navigationComand+6�   �� 5   
   $��AddStaff��66   $��1��6R   $��	Add Staff��6_   $��507,266,193,121q�6u   #��[ 6�   ��6   �� *navigationComand+6�   �� 5    
   $y�	Collapsed=�6   $	��↩��6(   $��LogIn��6Z   $��20(�6s     	triggerrr#��[ 6�   $��41,354,649,33q�6�   $
{�True��6�   $��1��6�   ��65   �� *navigationComand+6�   5"      5#      