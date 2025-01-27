using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Entidad
{
    public class EN_Persona
    {

        string _idpersonal;
        string _dni;

        string _Nombres;
        DateTime _añoNacmnto;
        string _sexo;
        string _RFC;    //NUEVO MIO
        string _Correo;
        //int _Celular;
        string _Celular;
        string _idrol;
        string _imagen;
        string _tipo;   //NUEVO MIO
        Single _FinguerPrint;
        string _estado;

        string _Direccion;
        string _Id_Seguro;
        string _distritoID;
        

        //REVISAR //REVISAR //REVISAR //REVISAR //REVISAR //REVISAR //REVISAR
        public Single FinfuerPrint //REVISAR //REVISAR //REVISAR //REVISAR
        {
            get { return _FinguerPrint; } //REVISAR //REVISAR //REVISAR
            set { _FinguerPrint = value; } //REVISAR //REVISAR //REVISAR
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string xImagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        public string IdRol
        {
            get { return _idrol; }
            set { _idrol = value; }
        }

        public string IdDistrito
        {
            get { return _distritoID; }
            set { _distritoID = value; }
        }

        public string Celular
        {
            get { return _Celular; }
            set { _Celular = value; }
        }

        public string IdSeguro
        {
            get { return _Id_Seguro; }
            set { _Id_Seguro = value; }
        }

        public string Correo
        {
            get { return _Correo; }
            set { _Correo = value; }
        }

        public string Idpersonal
        {
            get { return _idpersonal; }
            set { _idpersonal = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }

        public DateTime anoNacimiento
        {
            get { return _añoNacmnto; }
            set { _añoNacmnto = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

    }
}

