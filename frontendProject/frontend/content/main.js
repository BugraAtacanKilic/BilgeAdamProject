const url='http://localhost:3000';

async function GetEmployees(){
    const response=await fetch(url+"/employees");
    const employees=await response.json();
    return employees;
}

async function GetOrders(){
   const response=await fetch(url+"/orders");
   const orders=await response.json();
   const empList=await GetEmployees(); 
   CreateTable(orders,empList);
   return orders;
}
GetEmployees();
var ordersArr=GetOrders();

async function GetProducts(orderId){//benim değil
  Promise.all([ordersArr]).then(values =>{
    values.forEach((element)=>{
      const ord=element.find(x=>x.id==orderId);
      const dtl=ord.details;
      const dtlDiv=document.querySelector('.product-detail');
        dtlDiv.innerHTML="";
      dtl.forEach((element)=>{
        const div=document.createElement('div');
        div.classList.add('dtl-div');
        const p1=document.createElement('p');
        p1.innerText='Ürün ID:'+element.productId;
        const p2=document.createElement('p');
        p2.innerText='Fiyat:'+element.unitPrice;
        const p3=document.createElement('p');
        p3.innerText='Adet:'+element.quantity;
        
        div.appendChild(p1);
        div.appendChild(p2);
        div.appendChild(p3);

        dtlDiv.appendChild(div);
      })
    })
  })
}


function CreateTable(array,empArr){ //hintli dayı
    const divElement=document.querySelector(".table");
    const tableElement=document.createElement("table");
    tableElement.setAttribute("border","1");
    const theadElement = document.createElement("thead");
    const tbodyElement = document.createElement("tbody");

    const tr=document.createElement("tr");

    const th1=document.querySelector('.th1');
    const th2=document.querySelector('.th2');
    const th3=document.querySelector('.th3');
    const th4=document.querySelector('.th4');
    const th5=document.querySelector('.th5');
    const th6=document.querySelector('.th6');

    tr.appendChild(th1);
    tr.appendChild(th2);
    tr.appendChild(th3);
    tr.appendChild(th4);
    tr.appendChild(th5);
    tr.appendChild(th6);
    theadElement.appendChild(tr);


    for (let i = 0; i < array.length; i++) {
        const order = array[i];
        const tr1=document.createElement("tr");

        const td1=document.createElement("td");
        td1.innerText=order.id;
        const td2=document.createElement("td");
        td2.innerText=order.customerId;
        


        const td3=document.createElement("td");      
        const emp=empArr.find(x=>x.employeeId==order.employeeId);
        td3.innerText=emp.firstName+' '+emp.lastName; 



        const td4=document.createElement("td");
        td4.innerText=order.orderDate; //shortDate'e çevrilecek

        let detail=order.details;
        let totalPrice=0;
        detail.forEach(dtl => {
            totalPrice+=(dtl.unitPrice*dtl.quantity*(1-dtl.discount));
        });
        const td5=document.createElement("td");
      
        td5.innerText=totalPrice.toFixed(2);

        const td6=document.createElement("button");
        td6.innerText=order.id;
        
        td6.setAttribute('id',order.id);
        td6.addEventListener("click", btnFunc);
        function btnFunc() {
          const pnlId=document.querySelector('.pnl-id');
          pnlId.innerText=order.id;
          GetProducts(order.id);
        }

        tr1.appendChild(td1);
        tr1.appendChild(td2);
        tr1.appendChild(td3);
        tr1.appendChild(td4);
        tr1.appendChild(td5);
        tr1.appendChild(td6);

        tbodyElement.appendChild(tr1);
    }

    tableElement.appendChild(theadElement);
    tableElement.appendChild(tbodyElement);

    divElement.appendChild(tableElement);


    //Toplam Price ve Order Date'e göre sıralama //stackover
    const getCellValue = (tr, idx) => tr.children[idx].innerText || tr.children[idx].textContent;

    const comparer = (idx, asc) => (a, b) => ((v1, v2) => 
    v1 !== '' && v2 !== '' && !isNaN(v1) && !isNaN(v2) ? v1 - v2 : v1.toString().localeCompare(v2)
    )(getCellValue(asc ? a : b, idx), getCellValue(asc ? b : a, idx));

    document.querySelectorAll('.sorting').forEach(th => th.addEventListener('click', (() => {
      const table = th.closest('table');
      const tbody = table.querySelector('tbody');
  Array.from(tbody.querySelectorAll('tr'))
    .sort(comparer(Array.from(th.parentNode.children).indexOf(th), this.asc = !this.asc)) //comparer ??
    .forEach(tr => tbody.appendChild(tr) );
    })));   
}

function filterTable() {  //benim değil
  let dropdown, table, rows, cells, employee, filter; //variables
  dropdown = document.getElementById("employeesDropdown");
  table = document.getElementById("mytable");
  rows = table.getElementsByTagName("tr");
  filter = dropdown.value;

  for (let row of rows) { // rows's items loops through the NodeList
    cells = row.getElementsByTagName("td");
    employee = cells[2] || null; 
    if (filter === "All" || !employee || (filter === employee.textContent)) {
      row.style.display = ""; // shows this row
    }
    else {
      row.style.display = "none"; // hides this row
    }
  }
}

function inputFilter() { //stackover
  var input, filter, table, tr, td, i, txtValue;
  input = document.getElementById("myInput");
  filter = input.value.toUpperCase();
  table = document.getElementById("mytable");
  tr = table.getElementsByTagName("tr");

  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName("td")[1];
    if (td) {
      txtValue = td.textContent || td.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = "";
      } else {
        tr[i].style.display = "none";
      }
    }
  }
}
