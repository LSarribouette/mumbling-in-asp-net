import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('https://localhost:7249/');
  await page.getByRole('link', { name: 'Login' }).click();
  await page.getByLabel('Email').click();
  await page.getByLabel('Email').fill('user@test.fr');
  await page.getByLabel('Email').press('Tab');
  await page.getByLabel('Password').fill('Unsupermotdepasse0!');
  await page.getByLabel('Remember me?').check();
  await page.getByRole('button', { name: 'Log in' }).click();
});