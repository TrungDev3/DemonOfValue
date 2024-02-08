using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class UnitTargetsBehaviour : MonoBehaviour
    {
        [Header("Targets")]
        //Tạo danh sách chứa các đối tượng UnitController 
        public List<UnitController> targetUnits; // tạo 1 list để lấy các unit để target


    // Khai báo một phương thức public (công khai) có tên là AddTargetUnits, nhận đối số là một List<UnitController> được gọi là addedUnits.
    public void AddTargetUnits(List<UnitController> addedUnits)
    {
        // Xóa hết các phần tử trong danh sách targetUnits (nếu có).
        targetUnits.Clear();

        // Bắt đầu vòng lặp từ i = 0 đến khi i < số phần tử trong danh sách addedUnits.
        for (int i = 0; i < addedUnits.Count; i++)
        {
            // Thêm từng phần tử từ danh sách addedUnits vào danh sách targetUnits.
            targetUnits.Add(addedUnits[i]);
            
        }
    }


    public void RemoveTargetUnit(UnitController removedUnit)
        {
            targetUnits.Remove(removedUnit);
        }

    // Khai báo một phương thức public (công khai) có kiểu trả về là List<UnitController>, với đối số là targetType có kiểu là TargetType.
    public List<UnitController> FilterTargetUnits(TargetType targetType)
    {
        // Khởi tạo một danh sách mới có tên là filteredUnits để lưu trữ các đối tượng UnitController đã lọc.
        List<UnitController> filteredUnits = new List<UnitController>();

        // Kiểm tra nếu danh sách targetUnits không có phần tử nào.
        if (targetUnits.Count <= 0)
        {
            // Nếu không có phần tử nào trong targetUnits, trả về danh sách filteredUnits rỗng.
            return filteredUnits;
        }

        // Bắt đầu kiểm tra giá trị của biến targetType bằng cách sử dụng câu lệnh switch.
        switch (targetType)
        {
            // Trường hợp nếu targetType là RandomTarget.
            case TargetType.RandomTarget:
                // Tạo một số ngẫu nhiên trong khoảng từ 0 đến số phần tử trong danh sách targetUnits.
                int randomUnit = Random.Range(0, targetUnits.Count);
                // Thêm phần tử có chỉ số ngẫu nhiên từ danh sách targetUnits vào danh sách filteredUnits.
                filteredUnits.Add(targetUnits[randomUnit]);
                break;

            // Trường hợp nếu targetType là AllTargets.
            case TargetType.AllTargets:
                // Gán danh sách targetUnits cho filteredUnits.
                filteredUnits = targetUnits;
                break;
        }

        // Trả về danh sách filteredUnits chứa các đối tượng UnitController đã được lọc.
        return filteredUnits;
    }

    public UnitController GetRandomTargetUnit()
        {
            int randomUnit = Random.Range(0, targetUnits.Count);
            return targetUnits[randomUnit];
        }

        public List<UnitController> GetAllTargetUnits()
        {
            return targetUnits;
        }

    }


