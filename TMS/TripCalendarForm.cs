using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using Framework;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMS.Utilities;

namespace TMS
{
    public partial class TripCalendarForm : Form
    {
        public TripCalendarForm()
        {
            InitializeComponent();
        }

        private void TripCalendarForm_Load(object sender, EventArgs e)
        {
            UISetter.SetButtonAppearance(btnTrip);
            txtEnd.Value = DateTime.Now.AddDays(14);
            LoadTrips();
            var conn = new DataSupport();
        }

        private void calendarView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Main Calendar View hit

                if (sender is BaseView)
                    BaseViewMouseUp(sender, e);

                // AppointmentView hit
                else if (sender is AppointmentView)
                    AppointmentViewMouseUp(sender);

                // AllDayPanel hit
                else if (sender is AllDayPanel)
                    AllDayPanelMouseUp(sender);

                // TimeRulerPanel
                else if (sender is TimeRulerPanel)
                    TimeRulerPanelMouseUp();

                // TimeLineHeaderPanel
                else if (sender is TimeLineHeaderPanel)
                    TimeLineHeaderPanelMouseUp(sender, e);
            }
        }

        private void TimeLineHeaderPanelMouseUp(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TimeRulerPanelMouseUp()
        {
            throw new NotImplementedException();
        }

        private void AllDayPanelMouseUp(object sender)
        {
            throw new NotImplementedException();
        }

        private void AppointmentViewMouseUp(object sender)
        {
            AppointmentView view = sender as AppointmentView;

            // Select the appointment

            if (view != null)
            {
                view.IsSelected = true;

                // Let the user delete the appointment

                AppManageContextItem.Enabled = (view.Appointment.IsRecurringInstance == false);
                AppointmentContextMenu.Tag = view;
            }

            ShowContextMenu(AppointmentContextMenu);
        }

        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;

            if (view != null)
            {
                eViewArea area = view.GetViewAreaFromPoint(e.Location);

                switch (area)
                {
                    case eViewArea.InContent:
                        InContentMouseUp(view, e);
                        break;
                }
            }
        }

        private void InContentMouseUp(BaseView view, MouseEventArgs e)
        {
            {
                // Get the DateSelection start and end
                // from the current mouse location

                DateTime startDate, endDate;

                calendarView1.DateSelectionStart = null;
                calendarView1.DateSelectionEnd = null;

                if (calendarView1.GetDateSelectionFromPoint(e.Location, out startDate, out endDate) == true)
                {
                    // If this date already falls outside the currently
                    // selected range (DateSelectionStart and DateSelectionEnd)
                    // then select the new range

                    if (IsDateSelected(startDate, endDate) == false)
                    {
                        calendarView1.DateSelectionStart = startDate;
                        calendarView1.DateSelectionEnd = endDate;
                        ShowContextMenu(InContentContextMenu);
                    }
                }
            }
        }

        private void ShowContextMenu(ButtonItem cm)
        {
            Point pt = MousePosition;
            cm.Popup(pt);
        }

        private bool IsDateSelected(DateTime startDate, DateTime endDate)
        {
            if (startDate <= DateTime.Now.Date)
            {
                MessageBox.Show("Unable to add trip");
                return true;
            }
            return false;
        }

        private void MiNewTrip_Click(object sender, EventArgs e)
        {
            //using (var dialog = new AddTripDialog())
            //{
            //    dialog.ShowDialog();
            //    if (dialog.DialogResult == DialogResult.OK)
            //    {
            //        //LoadTrips();
            //    }
            //}
            //DateTime startDate = calendarView1.DateSelectionStart.GetValueOrDefault();
            //DateTime endDate = calendarView1.DateSelectionEnd.GetValueOrDefault();

            using (var dialog = new AddTripDialog())
            {
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadTrips();
                }
            }
        }

        private void AppManageContextItem_Click(object sender, EventArgs e)
        {
            ButtonItem mi = sender as ButtonItem;

            if (mi != null)
            {
                AppointmentView view = mi.Parent.Tag as AppointmentView;
                using (var dialog = new ManageTrips())
                {
                    Appointment ap = view.Appointment;

                    dialog.trip_id = ap.Subject;
                    dialog.ShowDialog();
                }
            }
        }

        private Appointment AddNewAppointment(DateTime startDate, DateTime endDate)
        {
            // Create new appointment and add it to the model
            // Appointment will show up in the view automatically

            Appointment appointment = new Appointment();

            appointment.StartTime = startDate;
            appointment.EndTime = endDate;

            appointment.Subject = "New " +
                appointment.CategoryColor + " appointment!";

            appointment.Description = "This is a new appointment";
            appointment.Tooltip = "This is a Custom tooltip for this new appointment";
            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);

            return (appointment);
        }

        private Appointment LoadAppointment(DateTime startDate, DateTime endDate)
        {
            Appointment appointment = new Appointment();

            appointment.StartTime = startDate;
            appointment.EndTime = endDate;

            appointment.Subject = "New " +
                appointment.CategoryColor + " appointment!";

            appointment.Description = "This is a new appointment";
            appointment.Tooltip = "This is a Custom tooltip for this new appointment";
            appointment.Locked = true;
            // Add appointment to the model

            calendarView1.CalendarModel.Appointments.Add(appointment);

            return (appointment);
        }

        private void LoadTrips()
        {
            DateTime start = DateTime.Parse(txtStart.Value.ToShortDateString());
            DateTime end = DateTime.Parse(txtEnd.Value.ToShortDateString());

            var trip_dt = DataSupport.RunDataSet("SELECT * FROM Trips WHERE expected_start >= '" + start + "' AND expected_end >='" + start + "'").Tables[0];

            calendarView1.CalendarModel.Appointments.Clear();

            foreach (DataRow row in trip_dt.Rows)
            {
                Appointment appointment = new Appointment();

                appointment.StartTime = Convert.ToDateTime(row["expected_start"]);
                appointment.EndTime = Convert.ToDateTime(row["expected_end"]).AddDays(1);
                appointment.Subject = row["trip_id"].ToString() + " " + appointment.CategoryColor;
                appointment.Description = $"Vehicle: { row["vehicle"] }\nIn-charged: { row["in_charge"] } ";
                appointment.Tooltip = $"Vehicle: { row["vehicle"] }\nIn-charged: { row["in_charge"] } ";
                appointment.CategoryColor = Appointment.CategoryOrange;
                appointment.Locked = true;
                appointment.DisplayTemplate = $"[Subject]" + "\n[Description]";
                calendarView1.CalendarModel.Appointments.Add(appointment);
            }
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Day;
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            calendarView1.SelectedView = eCalendarView.Month;
        }

        private void calendarView1_ItemDoubleClick(object sender, MouseEventArgs e)
        {
            using (var dialog = new ManageTrips())
            {
                AppointmentView item = sender as AppointmentView;

                if (item != null)
                {
                    Appointment ap = item.Appointment;

                    dialog.trip_id = ap.Subject;
                    dialog.ShowDialog();
                }
            }
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            using (var dialog = new AddTripDialog())
            {
                dialog.ShowDialog();
                if (dialog.DialogResult == DialogResult.OK)
                {
                    LoadTrips();
                }
            }
        }
    }
}