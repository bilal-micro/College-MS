   M S B A M L   `   `   `  ����D  @CollegeMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CollegeMS.View.Pages.DoctorCollegeMS.View.Pages.Doctor  5      I)clr-namespace:CollegeMS.View.UserControlsCollegeMS.View.UserControls  5      (    "CollegeMS.View.Pages.Doctor.MyData   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:CollegeMS.View.Pages.Doctor     5      BuserControls)clr-namespace:CollegeMS.View.UserControls     5         doctorViewModel  � DataContext#  [  5
       N� Title$ MyData��5      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      .+�5   
   *   $CollegeMS.View.UserControls.TitleBar  �� 5   
   $��1��6    K� ZIndex$ 0��6   ._�5      �� $%��/Assets/Doctor data modifed.png��6   $
��Fill=�6=   5      �� 5   
   $��1��6   $��Doctor Name :��6!     
TEXT_BLOCK#��[ 66   $��280,43,430,362q�6Z   �� 5   
   $��1��6   $��	Faculty :��6!   #��[ 62   $��280,94,430,311q�6V   �� 5   
   $��1��6   $��Email :��6!   #��[ 60   $��280,144,430,261q�6T   �� 5   
   $��1��6   $��Birthdate :��6!   #��[ 64   $��403,191,307,214q�6X   �� 5   
   $��1��6   $��Doctor ID :��6!   #��[ 64   $��535,43,175,362q�6X   �� 5   
   $��1��6   $��Doctor Major :��6!   #��[ 67   $��535,94,175,311q�6[   �� 5"   
   $��1��6   #��[ 6>   $��374,44,336,361q�6b   ��6!   �� *doctor.Name+6b   �� 5#   
   $��1��6   $'��!Computing and Information Systems��6!   $	��NaN��6J   $��8(�6V   #��[ 6c   $��335,99,307,306q�6�   �� 5$   
   $��1��6   $	��NaN��6?   #��[ 6K   $��324,143,318,262q�6o   ��6!   �� *doctor.Email+6o   �� 5%   
   $��1��6   #��[ 6C   $��473,191,237,214q�6g   ��6!   �� *doctor.BirthDate+6g   �� 5&   
   $��1��6   #��[ 6<   $��604,44,106,361q�6`   ��6!   �� *	doctor.id+6`   �� 5'   
   $��1��6   #��[ 6E   $��630,94,80,311q�6i   ��6!   �� *doctor.Course.Name+6i   �� 5*   
   $	��↩��6   $��DashBoardDoctor��6C   $��20(�6f     	triggerrr#��[ 6t   $��33,359,657,28q�6�   $
{�True��6�   $��1��6�   ��6   �� *navigationComand+6�   5,      5-      