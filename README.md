# Parcial2Hector

aprovecho para decir que tuve un pequeño error con la conexion de sql y no supe como arreglarlo, pasa que, la conexion se hace exitosamente y aunque 
El formulario MainForm se muestra, pero el DataGridView está vacío. (Parece que la causa principal de esto era el problema de permisos en la base de datos SQL Server, que impidió que la aplicación leyera los datos).
No se muestra ningún MessageBox de error, incluso con la excepción forzada en CargarDatosAlumnos(), (Esto me llevó a la conclusión de que el código dentro de CargarDatosAlumnos() probablemente no se estaba ejecutando debido a un problema anterior en el ciclo de vida del formulario o la falta de permisos que detenía la ejecución silenciosamente,
La conexión a la base de datos parecía establecerse correctamente, ya que no tuve errores de conexión explícitos.
Dado que sospeche que el problema central era la falta del rol db_datareader para mi usuario en la base de datos UMG, y no pude solucionarlo directamente debido al error persistente al intentar otorgar ese permiso, creo que llegue al punto donde preferi terminar todo lo que me faltaba del proyecto y dejar la conexion de ultimo (porque decidi ser feliz en semana santa y fue mala idea, no tenia mucho tiempo :()

