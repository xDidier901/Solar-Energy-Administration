package com.edge.solergy;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class Introduction extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_introduction);
    }

    public void mostrarObjetos(View view) {
        // Do something in response to button
        Intent intent = new Intent(this, Objects.class);
        startActivity(intent);
    }




}
