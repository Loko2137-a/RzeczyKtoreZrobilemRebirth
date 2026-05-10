package com.example.mobilka;

import android.os.Bundle;
import android.widget.CalendarView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Calendar;
import java.util.GregorianCalendar;

public class MainActivity extends AppCompatActivity {

    private CalendarView kalendarz;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        kalendarz = findViewById(R.id.calendarView);
        kalendarz.setOnDateChangeListener((view, year, month, dayOfMonth) -> {
            GregorianCalendar calendar = new GregorianCalendar(year, month, dayOfMonth);
            int dayOfWeek = calendar.get(Calendar.DAY_OF_WEEK);
            String dayName = "";
            switch (dayOfWeek) {
                case Calendar.MONDAY:
                    dayName = "Poniedziałek";
                    break;
                case Calendar.TUESDAY:
                    dayName = "Wtorek";
                    break;
                case Calendar.WEDNESDAY:
                    dayName = "Środa";
                    break;
                case Calendar.THURSDAY:
                    dayName = "Czwartek";
                    break;
                case Calendar.FRIDAY:
                    dayName = "Piątek";
                    break;
                case Calendar.SATURDAY:
                    dayName = "Sobota";
                    break;
                case Calendar.SUNDAY:
                    dayName = "Niedziela";
                    break;
            }
            Toast.makeText(this, +dayOfMonth + "." + month + " "+ dayName, Toast.LENGTH_SHORT).show();
        });
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
    }
}