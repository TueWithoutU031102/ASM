using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace ASM.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/Book")]
        [HttpGet]
        public IActionResult Index()
        { 
            return View(context.Books.ToList());
        }
        
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Books.Include(c => c.Category).FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        public IActionResult Order(int? id)
        {
            if (id == null)
            {
                return NotFound();            }
            var order = context.Books.Include(c => c.Category).FirstOrDefault(b => b.Id == id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add a new book successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(book);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var book = context.Books.Find(id);
                context.Books.Remove(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var book = context.Books.Find(id);
            if (book == null) return NotFound();
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Entry(book).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Message"] = "Book Has Been Change Successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(book);
        }
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var books = context.Books.Where(b => b.Title.Contains(keyword)).ToList();
            if (books.Count == 0)
            {
                TempData["Message"] = "No book found !";
            }
            return View("index", books);
        }
        public IActionResult SortNameAsc()
        {
            return View("Index",context.Books.OrderBy(b=>b.Title).ToList());
        }

        public IActionResult SortNameDesc()
        {
            return View("Index",context.Books.OrderByDescending(b=>b.Title).ToList());
        }

        /// Thêm sản phẩm vào cart
 /*       [Route("addcart/{bookid:int}")]
        public IActionResult AddToCart([FromRoute] int bookid)
        {
            var book = context.Books
                            .Where(b => b.Id == bookid)
                            .FirstOrDefault();
            if (book == null)
                return NotFound("There are nothing in the cart");

            // Xử lý đưa vào Cart ...
            return RedirectToAction(nameof(Cart));
        }*/

        /// xóa item trong cart
        [Route("/removecart/{bookid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int bookid)
        {
            // Xử lý xóa một mục của Cart ...
            return RedirectToAction(nameof(Cart));
        }

        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int bookid, [FromForm] int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            return RedirectToAction(nameof(Cart));
        }


        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            // Xử lý khi đặt hàng
            return View();
        }

        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItems()
        {

            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        /// Thêm sản phẩm vào cart
        [Route("addcart/{productid:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int bookid)
        {

            var book = context.Books
                .Where(b => b.Id == bookid)
                .FirstOrDefault();
            if (book == null)
                return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, book = book });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }
    }
}
