using MedSysList;

namespace MyListTests
{
    [TestClass]
    public class MyListUnitTests
    {
        //Delete functionality
        [TestMethod]
        public void Delete_PassedIncludedValue_ValueDeleted()
        {
            var _value = 6;
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, _value
                }
            );

            _myList.Delete( _value );

            Assert.IsFalse(_myList.ReadList().Contains(_value));
        }

        [TestMethod]
        public void Delete_PassedExcludedValue_CountUnchanged()
        {
            var _value = 7;
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );

            var _beforeCount = _myList.ReadList().Count;

            _myList.Delete(_value);

            var _afterCount = _myList.ReadList().Count;

            Assert.AreEqual(_beforeCount, _afterCount);
        }

        [TestMethod]
        public void Delete_NullList_NoDeleteNoError()
        {
            var _value = 7;
            var _myList = new MyList<int>();

            try
            {
                _myList.Delete( _value );
            }
            catch ( Exception ex ) 
            { 
                Assert.Fail( ex.Message );
            }

        }

        [TestMethod]
        public void Delete_NullValue_ThrowError()
        {
            var _myList = new MyList<string>();

            Assert.ThrowsException<ArgumentNullException>(() => _myList.Delete(null));
        }

        //Add functionality
        [TestMethod]
        public void Add_PassedValue_ContainsValue()
        {
            var _value = 7;
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );

            var _existsBeforeAdd = _myList.ReadList().Contains(_value);
            _myList.Add(_value);
            var _existsAfterAdd = _myList.ReadList().Contains(_value);

            Assert.IsFalse(_existsBeforeAdd);
            Assert.IsTrue(_existsAfterAdd);
        }

        [TestMethod]
        public void Add_PassedExistingValue_CountIncreased()
        {
            var _value = 6;
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );

            var _beforeCount = _myList.ReadList().Count;
            _myList.Add(_value);
            var _afterCount = _myList.ReadList().Count;

            Assert.IsTrue(_myList.ReadList().Contains(_value));
            Assert.IsTrue(_afterCount > _beforeCount);
        }

        [TestMethod]
        public void Add_NullValue_ThrowError()
        {
            var _myList = new MyList<string>();

            Assert.ThrowsException<ArgumentNullException>(()=>_myList.Add(null));
        }

        //ReadValueAtIndex functionality
        [TestMethod]
        public void ReadValueAtIndex_PassedIndexWithinBounds_ReturnsValue()
        {
            var _index = 3;
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );

            var _returnedValue = _myList.ReadValueAtIndex(_index);

            Assert.IsTrue(_returnedValue == 4);
        }

        [TestMethod]
        public void ReadValueAtIndex_PassedIndexOutOfBounds_ThrowsError()
        {
            var _myList = new MyList<int>
            (
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                }
            );
            var _index = _myList.ReadList().Count;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _myList.ReadValueAtIndex(_index));
        }

        //ReadList functionality
        [TestMethod]
        public void ReadList_InitializeList_ReturnsList()
        {
            var _myList1 =
                new List<int>()
                {
                    1, 2, 3, 4, 5, 6
                };
            var _myList2 = new MyList<int>(_myList1);

            Assert.AreEqual(_myList1, _myList2.ReadList());
        }

        [TestMethod]
        public void ReadList_NoInitializeList_ReturnsEmptyList()
        {
            var _myList = new MyList<int>();

            Assert.IsFalse(_myList.ReadList().Any());
        }

    }
}