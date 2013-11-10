﻿using TgcViewer.Utils.TgcGeometry;

namespace AlumnoEjemplos.RandomGroup
{
    public interface ElementoEstatico
    {
        //esta interfaz es solo para poder manejar indistintamente los objetos estaticos en la grilla regular
        void render(float elapsedTime);
        TgcBoundingBox getBoundingBox();
        bool getEnabled();
        void setEnabled(bool state);

    }
}