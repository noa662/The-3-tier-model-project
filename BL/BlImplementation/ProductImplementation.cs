﻿using BlApi;
using BO;
namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product p)
    {
        try
        {
            return _dal.Product.Create(p.Convert());
        }
        catch
        {
            throw new BLAlreadyExistsException("this item already exist");
        }
    }
    public BO.Product Read(int id)
    {
        try
        {
            return _dal.Product.Read(id)?.Convert();
        }
        catch
        {
            throw new BLNotFoundException("this item is not exist");
        }
    }
    public BO.Product? Read(Func<BO.Product, bool> filter)
    {
        try
        {
            return _dal.Product.ReadAll().Select(c => c.Convert()).FirstOrDefault(filter);
        }
        catch
        {
            throw new BLNotFoundException("items is not exists");
        }
    }
    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        try
        {
            if (filter == null)
                return _dal.Product.ReadAll().Select(c => c.Convert()).ToList();
            return _dal.Product.ReadAll().Select(c => c.Convert()).Where(filter).ToList();
        }
        catch
        {
            throw new BLNotFoundException("items is not exists");
        }
    }
    public void Update(BO.Product item)
    {
        try
        {
            _dal.Product.Update(item.Convert());
        }
        catch (Exception ex)
        {
            throw new BLAccessException("error in update item");
        }
    }
    public void Delete(int id)
    {
        try
        {
            _dal.Product.Delete(id);
        }
        catch
        {
            throw new BLNotFoundException("id is not exist");
        }
    }
    public List<BO.Product> getListSales(int id, bool favorite)
    {
        try
        {
            return _dal.Product.ReadAll()
                .Select(p => p.Convert())
                .Where(p => p.saleInProduct != null && p.saleInProduct
                .Any(s => s.SaleId == id && favorite)).ToList();
        }
        catch
        {
            throw new BLNotFoundException("items is not exists");
        }
    }
}
