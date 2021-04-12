Sesión 1
 - Crear Solucion
 - Limpiar proyectos (Quitar Componentes, Models, css, etc.)
 - Agregar font quicksand
 - Crear Icono
 - Crear progressbar-slide para sustituir la 'Loading...'

https://ticapacitacion.com/resources/courses/blazorwasm/font.zip

https://ticapacitacion.com/resources/courses/blazorwasm/images/icon-512.png

Sesión 2
 - Create Entities (PizzaSpecial) - SHARED
 - Create Context (PizzaStoreContext) - SERVER
 - Add ConnectionString (PizzaStoreContext) - SERVER
 - Migrate Init, Update Database - SERVER
 - Create Controller (SpecialsController) - SERVER
 - New Class SeedData - SERVER
 - 2:10:40 arreglo de Pizzas
 - Migracios de datos si esta la DB vacia (Program.cs) - SERVER
 - Importar images - CLIENTE
 - Program.cs CLIENTE es donde se define la Ruta donde esta el API
 - Add Class Styles en app.cs for <DIV>s -CLIENT
 - Add List<PizzaSpecial> Specials AND OnInitializedAsync en index.razor CLIENT

https://ticapacitacion.com/resources/courses/blazorwasm/imagespizzas.zip


Sesión 3
error Microsoft.TypeScript.MSBuild
 *Los enlaces que NO empiezan con / se asocian al <base href="/" /> de index.html
 - app.css apartir de .top-bar
 - modificar index.razor -CLIENT
 Backup .zip del proyecto
 - class Pizza, PizzaTopping, Topping -SHARED
 - Modificar PizzaStoreContext -SERVER
 - Add-Migration and Update-Database
 - agregar Componente Razor ConfigurePizzaDialog
 - app.css apartir de form
 - Modificar ConfigurePizzaDialog.razor -CLIENTE

https://ticapacitacion.com/resources/courses/blazorwasm/images/logo.svg
https://ticapacitacion.com/resources/courses/blazorwasm/images/pizza-slice.svg

*Referencia ConfigurePizzaDialog.razor
<input type="range" 
    min="@Pizza.MinimumSize" 
    max="@Pizza.MaximumSize" 
    step="@Pizza.IncrementSize" 
    value="@Pizza.Size"
    @onchange="@((ChangeEventArgs e) => Pizza.Size = int.Parse((string)e.Value))" />


Sesión 4
 - agregar ToppingsController
 - agregar Codigo para Toppings ConfigurePizzaDialog.razor
 - agregar Styles app.css
 - modifcar index.razor -CLIENTE
 - 

Sesión 5
 - Nueva Class Address, LatLong, Order
 - Add-Migration 
 - Nuevo OrdersController.cs
 - CSS .car-item  1:05:00
 - 21 Toppings 1:49:34
 - image https://ticapacitacion.com/resources/courses/blazorwasm/images/bike.svg
 - page: MyOrders, modificar MainLayout.razor
 - New Proyecto BlazingPizza.ComponentsLibrary


Sesión 6
 - New class OrderWithStatus -SHARED
 - Order Controller new class HttpGet
 - Terminar MyOrders.razor
 - Agregar Estilos CSS apartir de: .orders-list .list-group-item


Sesión 7
 - Creando componentes reutilizables en Blazor (Table)

Sesión 8
 - Creando componentes reutilizables en Blazor (Select)

Sesión 9
 - Nuevo componente OrderDetails.razor
 - Nuevo Metodo GET en OrdersController GetOrderWithStatus
 - mas Estilos .track-order
 - 

Sesión 10
 - Nuevo componente OrderReview.razor
 - Agregar estilos CSS apartir de: track-order-details
 - Order.cs new GetFormattedCreatedTime Propierty
 - index.razor modified Method PlaceOrder
 - final capitulo 4 commit y push
 - new folder Services
 - new Class OrderState que es el AppState
 - proyect Client program.cs new line : builder.Services.AddScoped<OrderState>();
 - mover todos los metodos de Index a OrderState
